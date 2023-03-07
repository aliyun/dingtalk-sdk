<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\QueryUserBehaviorResponseBody;

use AlibabaCloud\Tea\Model;

class data extends Model
{
    /**
     * @var string
     */
    public $pictureUrl;

    /**
     * @var int
     */
    public $platform;

    /**
     * @var string
     */
    public $scene;

    /**
     * @var int
     */
    public $time;

    /**
     * @var int
     */
    public $type;

    /**
     * @var string
     */
    public $userName;
    protected $_name = [
        'pictureUrl' => 'pictureUrl',
        'platform'   => 'platform',
        'scene'      => 'scene',
        'time'       => 'time',
        'type'       => 'type',
        'userName'   => 'userName',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->pictureUrl) {
            $res['pictureUrl'] = $this->pictureUrl;
        }
        if (null !== $this->platform) {
            $res['platform'] = $this->platform;
        }
        if (null !== $this->scene) {
            $res['scene'] = $this->scene;
        }
        if (null !== $this->time) {
            $res['time'] = $this->time;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
        }
        if (null !== $this->userName) {
            $res['userName'] = $this->userName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return data
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['pictureUrl'])) {
            $model->pictureUrl = $map['pictureUrl'];
        }
        if (isset($map['platform'])) {
            $model->platform = $map['platform'];
        }
        if (isset($map['scene'])) {
            $model->scene = $map['scene'];
        }
        if (isset($map['time'])) {
            $model->time = $map['time'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }
        if (isset($map['userName'])) {
            $model->userName = $map['userName'];
        }

        return $model;
    }
}
