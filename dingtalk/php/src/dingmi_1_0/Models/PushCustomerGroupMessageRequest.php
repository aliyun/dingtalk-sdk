<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdingmi_1_0\Models;

use AlibabaCloud\Tea\Model;

class PushCustomerGroupMessageRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example cidxxxx
     *
     * @var string
     */
    public $conversationId;

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
    protected $_name = [
        'conversationId' => 'conversationId',
        'msgKey'         => 'msgKey',
        'msgParam'       => 'msgParam',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->conversationId) {
            $res['conversationId'] = $this->conversationId;
        }
        if (null !== $this->msgKey) {
            $res['msgKey'] = $this->msgKey;
        }
        if (null !== $this->msgParam) {
            $res['msgParam'] = $this->msgParam;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return PushCustomerGroupMessageRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['conversationId'])) {
            $model->conversationId = $map['conversationId'];
        }
        if (isset($map['msgKey'])) {
            $model->msgKey = $map['msgKey'];
        }
        if (isset($map['msgParam'])) {
            $model->msgParam = $map['msgParam'];
        }

        return $model;
    }
}
