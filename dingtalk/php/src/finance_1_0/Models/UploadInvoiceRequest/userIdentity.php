<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\UploadInvoiceRequest;

use AlibabaCloud\Tea\Model;

class userIdentity extends Model
{
    /**
     * @example 95188
     *
     * @var string
     */
    public $mobile;

    /**
     * @example 86
     *
     * @var string
     */
    public $mobileStateCode;

    /**
     * @example dinng1123434
     *
     * @var string
     */
    public $targetCorpId;

    /**
     * @example STAFF_ID
     *
     * @var string
     */
    public $type;

    /**
     * @example akdfwiiw
     *
     * @var string
     */
    public $unionId;

    /**
     * @example 02734930
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'mobile'          => 'mobile',
        'mobileStateCode' => 'mobileStateCode',
        'targetCorpId'    => 'targetCorpId',
        'type'            => 'type',
        'unionId'         => 'unionId',
        'userId'          => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->mobile) {
            $res['mobile'] = $this->mobile;
        }
        if (null !== $this->mobileStateCode) {
            $res['mobileStateCode'] = $this->mobileStateCode;
        }
        if (null !== $this->targetCorpId) {
            $res['targetCorpId'] = $this->targetCorpId;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return userIdentity
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['mobile'])) {
            $model->mobile = $map['mobile'];
        }
        if (isset($map['mobileStateCode'])) {
            $model->mobileStateCode = $map['mobileStateCode'];
        }
        if (isset($map['targetCorpId'])) {
            $model->targetCorpId = $map['targetCorpId'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
