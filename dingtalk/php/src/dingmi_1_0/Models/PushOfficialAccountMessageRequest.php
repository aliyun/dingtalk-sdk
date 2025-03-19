<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdingmi_1_0\Models;

use AlibabaCloud\Tea\Model;

class PushOfficialAccountMessageRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example sampleText
     *
     * @var string
     */
    public $msgKey;

    /**
     * @description This parameter is required.
     *
     * @example eyJjb250ZW50IjogIua1i+ivleWGheWuuSJ9(即{"content": "测试内容"}的base64编码值)
     *
     * @var string
     */
    public $msgParam;

    /**
     * @description This parameter is required.
     *
     * @example 123456abc
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'msgKey' => 'msgKey',
        'msgParam' => 'msgParam',
        'userId' => 'userId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->msgKey) {
            $res['msgKey'] = $this->msgKey;
        }
        if (null !== $this->msgParam) {
            $res['msgParam'] = $this->msgParam;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return PushOfficialAccountMessageRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['msgKey'])) {
            $model->msgKey = $map['msgKey'];
        }
        if (isset($map['msgParam'])) {
            $model->msgParam = $map['msgParam'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
