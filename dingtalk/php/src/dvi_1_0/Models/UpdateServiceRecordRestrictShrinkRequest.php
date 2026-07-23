<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateServiceRecordRestrictShrinkRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $action;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $recordIdsShrink;
    protected $_name = [
        'action' => 'action',
        'recordIdsShrink' => 'recordIds',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->action) {
            $res['action'] = $this->action;
        }
        if (null !== $this->recordIdsShrink) {
            $res['recordIds'] = $this->recordIdsShrink;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateServiceRecordRestrictShrinkRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['action'])) {
            $model->action = $map['action'];
        }
        if (isset($map['recordIds'])) {
            $model->recordIdsShrink = $map['recordIds'];
        }

        return $model;
    }
}
