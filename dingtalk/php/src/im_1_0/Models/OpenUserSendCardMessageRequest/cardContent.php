<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\OpenUserSendCardMessageRequest;

use AlibabaCloud\Tea\Model;

class cardContent extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $lastMessage;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $outTrackId;
    protected $_name = [
        'lastMessage' => 'lastMessage',
        'outTrackId' => 'outTrackId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->lastMessage) {
            $res['lastMessage'] = $this->lastMessage;
        }
        if (null !== $this->outTrackId) {
            $res['outTrackId'] = $this->outTrackId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return cardContent
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['lastMessage'])) {
            $model->lastMessage = $map['lastMessage'];
        }
        if (isset($map['outTrackId'])) {
            $model->outTrackId = $map['outTrackId'];
        }

        return $model;
    }
}
