window.ShowToastr = (type, message) => {
    if (type === "success") {
        toastr.success(message, 'Succesful')
    }
    if (type === "error") {
        toastr.error(message, 'Failed')
    }
    if (type === "info") {
        toastr.info(message, 'Info')
    }
    if (type === "warning") {
        toastr.warning(message, 'Warning')
    }
}