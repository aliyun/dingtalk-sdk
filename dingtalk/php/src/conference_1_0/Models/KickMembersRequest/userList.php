<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\KickMembersRequest;

use AlibabaCloud\Tea\Model;

class userList extends Model
{
    /**
     * @example 644272f14ba3311xxxxxxxxx
     *
     * @var string
     */
    public $participantId;

    /**
     * @description This parameter is required.
     *
     * @example qzR1iSMDvzR9iP7Pxxxxxxxxxxxxxxx
     *
     * @var string
     */
    public $unionId;
    protected $_name = [
        'participantId' => 'participantId',
        'unionId'       => 'unionId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->participantId) {
            $res['participantId'] = $this->participantId;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return userList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['participantId'])) {
            $model->participantId = $map['participantId'];
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }

        return $model;
    }
}
