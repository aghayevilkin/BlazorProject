redirectToCheckout = function (sessionId) {
    var stripe = Stripe('pk_test_51KTgXeKgyLsNtiJcannrqo5en260V5qTuv7khCjKYtdoSve71zQmUjDdqVUMmhuc0eEKNbm1QOhzgMoMWCcUSumj00VbKk6RVV');
    stripe.redirectToCheckout({
        sessionId: sessionId
    });
};