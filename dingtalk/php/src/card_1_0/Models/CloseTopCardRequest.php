<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models;

use AlibabaCloud\Tea\Model;

class CloseTopCardRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example example_open_conversation_id
     *
     * @var string
     */
    public $openConversationId;

    /**
     * @description This parameter is required.
     *
     * @example example_out_track_id
     *
     * @var string
     */
    public $outTrackId;
    protected $_name = [
        'openConversationId' => 'openConversationId',
        'outTrackId' => 'outTrackId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->openConversationId) {
            $res['openConversationId'] = $this->openConversationId;
        }
        if (null !== $this->outTrackId) {
            $res['outTrackId'] = $this->outTrackId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CloseTopCardRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['openConversationId'])) {
            $model->openConversationId = $map['openConversationId'];
        }
        if (isset($map['outTrackId'])) {
            $model->outTrackId = $map['outTrackId'];
        }

        return $model;
    }
}
