<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models;

use AlibabaCloud\Tea\Model;

class MuteAllRequest extends Model
{
    /**
     * @example mute
     *
     * @var string
     */
    public $action;

    /**
     * @var bool
     */
    public $forceMute;
    protected $_name = [
        'action'    => 'action',
        'forceMute' => 'forceMute',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->action) {
            $res['action'] = $this->action;
        }
        if (null !== $this->forceMute) {
            $res['forceMute'] = $this->forceMute;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return MuteAllRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['action'])) {
            $model->action = $map['action'];
        }
        if (isset($map['forceMute'])) {
            $model->forceMute = $map['forceMute'];
        }

        return $model;
    }
}
