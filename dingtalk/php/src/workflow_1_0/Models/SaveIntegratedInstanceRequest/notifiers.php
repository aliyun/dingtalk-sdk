<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\SaveIntegratedInstanceRequest;

use AlibabaCloud\Tea\Model;

class notifiers extends Model
{
    /**
     * @example start
     *
     * @var string
     */
    public $position;

    /**
     * @example manager001
     *
     * @var string
     */
    public $userid;
    protected $_name = [
        'position' => 'position',
        'userid'   => 'userid',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->position) {
            $res['position'] = $this->position;
        }
        if (null !== $this->userid) {
            $res['userid'] = $this->userid;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return notifiers
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['position'])) {
            $model->position = $map['position'];
        }
        if (isset($map['userid'])) {
            $model->userid = $map['userid'];
        }

        return $model;
    }
}
