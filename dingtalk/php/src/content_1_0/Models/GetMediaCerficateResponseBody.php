<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontent_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetMediaCerficateResponseBody extends Model
{
    /**
     * @example 378a1a01**********6fa2886313948e
     *
     * @var string
     */
    public $mediaId;

    /**
     * @example STS.NTR**********q8LrHkgS7w97
     *
     * @var string
     */
    public $ossAccessKeyId;

    /**
     * @example DFCXzE5r8x9d4kp**********r1N8eUeh5aU7tM9vVcu
     *
     * @var string
     */
    public $ossAccessKeySecret;

    /**
     * @example outin-5e342d**********8bfb00163e024c6a
     *
     * @var string
     */
    public $ossBucketName;

    /**
     * @example https://oss-cn-*******.aliyuncs.com
     *
     * @var string
     */
    public $ossEndpoint;

    /**
     * @example 3000
     *
     * @var string
     */
    public $ossExpiration;

    /**
     * @example sv/1c****53-17a*****202/1c****53-17a*****02.mp4
     *
     * @var string
     */
    public $ossFileName;

    /**
     * @example CAIS0AR1q6Ft5B2yfSjIr5**********+au5c1eJqHIdZ+h/2LKS***********oAO8fvvU0m2tY7PsZlrUqFMQZHBaUPJoutc0OoFL4JpfZv8u84YADi5C***********28Wf7waf+AUBXGCTm***********lQCZuW//toJV7b9MRcxClZD5dfrl/LRdjr8lo1xGzUPG2KUzSn3b3BkhlsRYe72Rk8vaHxdaAzRDcgVbmqJcSvJ+jC4C8Ys9gG519XtypvopxbbGT8CNZ5z9A9qp9kM49/izc7P6QH35b4RiNL8/Z7tQNXwhiffobHa9YrfHgmNhlvvDSj43t1ytVOeZcX0akQ5u7ku7ZHP+oLt8jaYvjP3PE3rLpMYLu4T48ZXUSODtDYcZDUHhrEk4RUjXdI6Of8UrWSQC7Wsr217otg7Fyyk3s8MaHAkWLX7SB2DwEB4c4aEokVW4RxnezW6UBaRBpbld7Bq6cV5lOdBRZoK+KzQrJTX9Ez2pLmuD6e/LOs7oDVJ37WZtKyuh4Y49d4U8rVEjPQqiykT0pFgpfTK1RzbPmNLKm9baB25/zW+PdDe0dsVgoIFKOpiGWG3RLNn+ztJ9xbkeE+sKUkaGXr8lsTAIl6t4CVFiIIIZnoVY+u/LstBnLqrPoDHnt5XR/uPugptgRuRo8I6372bTJ42WG5Ub9O/dpxJ3lP0R0WgmydnBDx/Sfu2kKvRhpkRvvZEpPtwzIij/gLZZEiazRmyhefo5XmPXFTQmn8l5pAMmy/60xXudvbE2R0EQDY9YCGoABVx6uDvU/Q1kkRe4S00MofmJkOWVwk8jVgBbmlA6LUJQm70f9nksTLYjJ2HVOFHQO8MrnE2ur/xx5jYWpCHI0Aa4sGCjZShV0NNuT8yqNmGOKUReffWW47gxKv5Hhc6j8cAKUMZivrqCCuQaEqhNnKjDH7NS3PsXXyvhNF1KS6uQ=
     *
     * @var string
     */
    public $ossSecurityToken;
    protected $_name = [
        'mediaId'            => 'mediaId',
        'ossAccessKeyId'     => 'ossAccessKeyId',
        'ossAccessKeySecret' => 'ossAccessKeySecret',
        'ossBucketName'      => 'ossBucketName',
        'ossEndpoint'        => 'ossEndpoint',
        'ossExpiration'      => 'ossExpiration',
        'ossFileName'        => 'ossFileName',
        'ossSecurityToken'   => 'ossSecurityToken',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->mediaId) {
            $res['mediaId'] = $this->mediaId;
        }
        if (null !== $this->ossAccessKeyId) {
            $res['ossAccessKeyId'] = $this->ossAccessKeyId;
        }
        if (null !== $this->ossAccessKeySecret) {
            $res['ossAccessKeySecret'] = $this->ossAccessKeySecret;
        }
        if (null !== $this->ossBucketName) {
            $res['ossBucketName'] = $this->ossBucketName;
        }
        if (null !== $this->ossEndpoint) {
            $res['ossEndpoint'] = $this->ossEndpoint;
        }
        if (null !== $this->ossExpiration) {
            $res['ossExpiration'] = $this->ossExpiration;
        }
        if (null !== $this->ossFileName) {
            $res['ossFileName'] = $this->ossFileName;
        }
        if (null !== $this->ossSecurityToken) {
            $res['ossSecurityToken'] = $this->ossSecurityToken;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetMediaCerficateResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['mediaId'])) {
            $model->mediaId = $map['mediaId'];
        }
        if (isset($map['ossAccessKeyId'])) {
            $model->ossAccessKeyId = $map['ossAccessKeyId'];
        }
        if (isset($map['ossAccessKeySecret'])) {
            $model->ossAccessKeySecret = $map['ossAccessKeySecret'];
        }
        if (isset($map['ossBucketName'])) {
            $model->ossBucketName = $map['ossBucketName'];
        }
        if (isset($map['ossEndpoint'])) {
            $model->ossEndpoint = $map['ossEndpoint'];
        }
        if (isset($map['ossExpiration'])) {
            $model->ossExpiration = $map['ossExpiration'];
        }
        if (isset($map['ossFileName'])) {
            $model->ossFileName = $map['ossFileName'];
        }
        if (isset($map['ossSecurityToken'])) {
            $model->ossSecurityToken = $map['ossSecurityToken'];
        }

        return $model;
    }
}
