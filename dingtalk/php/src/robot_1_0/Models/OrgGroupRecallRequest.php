<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models;

use AlibabaCloud\Tea\Model;

class OrgGroupRecallRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example cidfCSpXXXXXXXXXXXchatbotId
     *
     * @var string
     */
    public $openConversationId;

    /**
     * @description This parameter is required.
     *
     * @var string[]
     */
    public $processQueryKeys;

    /**
     * @description This parameter is required.
     *
     * @example dingXXXXXXXXXX
     *
     * @var string
     */
    public $robotCode;
    protected $_name = [
        'openConversationId' => 'openConversationId',
        'processQueryKeys'   => 'processQueryKeys',
        'robotCode'          => 'robotCode',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->openConversationId) {
            $res['openConversationId'] = $this->openConversationId;
        }
        if (null !== $this->processQueryKeys) {
            $res['processQueryKeys'] = $this->processQueryKeys;
        }
        if (null !== $this->robotCode) {
            $res['robotCode'] = $this->robotCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return OrgGroupRecallRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['openConversationId'])) {
            $model->openConversationId = $map['openConversationId'];
        }
        if (isset($map['processQueryKeys'])) {
            if (!empty($map['processQueryKeys'])) {
                $model->processQueryKeys = $map['processQueryKeys'];
            }
        }
        if (isset($map['robotCode'])) {
            $model->robotCode = $map['robotCode'];
        }

        return $model;
    }
}
