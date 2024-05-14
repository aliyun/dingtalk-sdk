<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\Tea\Model;

class BatchQueryFamilySchoolMessageRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example cidxxxx
     *
     * @var string
     */
    public $openConversationId;

    /**
     * @description This parameter is required.
     *
     * @var string[]
     */
    public $openMessageIds;

    /**
     * @description This parameter is required.
     *
     * @example xxx
     *
     * @var string
     */
    public $unionId;
    protected $_name = [
        'openConversationId' => 'openConversationId',
        'openMessageIds'     => 'openMessageIds',
        'unionId'            => 'unionId',
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
        if (null !== $this->openMessageIds) {
            $res['openMessageIds'] = $this->openMessageIds;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return BatchQueryFamilySchoolMessageRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['openConversationId'])) {
            $model->openConversationId = $map['openConversationId'];
        }
        if (isset($map['openMessageIds'])) {
            if (!empty($map['openMessageIds'])) {
                $model->openMessageIds = $map['openMessageIds'];
            }
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }

        return $model;
    }
}
