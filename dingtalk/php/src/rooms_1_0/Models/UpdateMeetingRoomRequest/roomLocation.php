<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\UpdateMeetingRoomRequest;

use AlibabaCloud\Tea\Model;

class roomLocation extends Model
{
    /**
     * @example xx市xx区xx路xx号
     *
     * @var string
     */
    public $desc;

    /**
     * @example xxx公司
     *
     * @var string
     */
    public $title;
    protected $_name = [
        'desc'  => 'desc',
        'title' => 'title',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->desc) {
            $res['desc'] = $this->desc;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return roomLocation
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['desc'])) {
            $model->desc = $map['desc'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }

        return $model;
    }
}
