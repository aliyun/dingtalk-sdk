<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\Tea\Model;

class UserListValue extends Model
{
    /**
     * @var int
     */
    public $joinTime;

    /**
     * @var int
     */
    public $modifyTime;

    /**
     * @var bool
     */
    public $mute;

    /**
     * @var bool
     */
    public $topRank;

    /**
     * @var bool
     */
    public $visible;
    protected $_name = [
        'joinTime' => 'joinTime',
        'modifyTime' => 'modifyTime',
        'mute' => 'mute',
        'topRank' => 'topRank',
        'visible' => 'visible',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->joinTime) {
            $res['joinTime'] = $this->joinTime;
        }
        if (null !== $this->modifyTime) {
            $res['modifyTime'] = $this->modifyTime;
        }
        if (null !== $this->mute) {
            $res['mute'] = $this->mute;
        }
        if (null !== $this->topRank) {
            $res['topRank'] = $this->topRank;
        }
        if (null !== $this->visible) {
            $res['visible'] = $this->visible;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UserListValue
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['joinTime'])) {
            $model->joinTime = $map['joinTime'];
        }
        if (isset($map['modifyTime'])) {
            $model->modifyTime = $map['modifyTime'];
        }
        if (isset($map['mute'])) {
            $model->mute = $map['mute'];
        }
        if (isset($map['topRank'])) {
            $model->topRank = $map['topRank'];
        }
        if (isset($map['visible'])) {
            $model->visible = $map['visible'];
        }

        return $model;
    }
}
