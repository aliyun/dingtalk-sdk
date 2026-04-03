<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\ListAiMinutesResponseBody;

use AlibabaCloud\Tea\Model;

class minutes extends Model
{
    /**
     * @var string
     */
    public $creatorUserId;

    /**
     * @var string
     */
    public $minutesId;
    protected $_name = [
        'creatorUserId' => 'creatorUserId',
        'minutesId' => 'minutesId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->creatorUserId) {
            $res['creatorUserId'] = $this->creatorUserId;
        }
        if (null !== $this->minutesId) {
            $res['minutesId'] = $this->minutesId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return minutes
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['creatorUserId'])) {
            $model->creatorUserId = $map['creatorUserId'];
        }
        if (isset($map['minutesId'])) {
            $model->minutesId = $map['minutesId'];
        }

        return $model;
    }
}
