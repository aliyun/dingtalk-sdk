<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetLeaveTypeResponseBody\result;

use AlibabaCloud\Tea\Model;

class visibilityRules extends Model
{
    /**
     * @example staff
     *
     * @var string
     */
    public $type;

    /**
     * @var string[]
     */
    public $visible;
    protected $_name = [
        'type' => 'type',
        'visible' => 'visible',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->type) {
            $res['type'] = $this->type;
        }
        if (null !== $this->visible) {
            $res['visible'] = $this->visible;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return visibilityRules
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }
        if (isset($map['visible'])) {
            if (!empty($map['visible'])) {
                $model->visible = $map['visible'];
            }
        }

        return $model;
    }
}
