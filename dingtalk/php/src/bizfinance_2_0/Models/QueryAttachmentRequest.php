<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models;

use AlibabaCloud\Tea\Model;

class QueryAttachmentRequest extends Model
{
    /**
     * @var string
     */
    public $attachmentType;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $businessId;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'attachmentType' => 'attachmentType',
        'businessId' => 'businessId',
        'userId' => 'userId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->attachmentType) {
            $res['attachmentType'] = $this->attachmentType;
        }
        if (null !== $this->businessId) {
            $res['businessId'] = $this->businessId;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryAttachmentRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['attachmentType'])) {
            $model->attachmentType = $map['attachmentType'];
        }
        if (isset($map['businessId'])) {
            $model->businessId = $map['businessId'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
