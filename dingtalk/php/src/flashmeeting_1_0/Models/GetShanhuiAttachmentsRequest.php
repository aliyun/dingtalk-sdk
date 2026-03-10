<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vflashmeeting_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetShanhuiAttachmentsRequest extends Model
{
    /**
     * @var string
     */
    public $shanhuiKey;

    /**
     * @var string
     */
    public $userId;
    protected $_name = [
        'shanhuiKey' => 'shanhuiKey',
        'userId' => 'userId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->shanhuiKey) {
            $res['shanhuiKey'] = $this->shanhuiKey;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetShanhuiAttachmentsRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['shanhuiKey'])) {
            $model->shanhuiKey = $map['shanhuiKey'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
