<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vokr_1_0\Models\CreateObjectiveResponseBody;

use AlibabaCloud\Tea\Model;

class data extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 58YD
     *
     * @var string
     */
    public $id;

    /**
     * @description This parameter is required.
     *
     * @example 33453
     *
     * @var string
     */
    public $position;
    protected $_name = [
        'id'       => 'id',
        'position' => 'position',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
        if (null !== $this->position) {
            $res['position'] = $this->position;
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
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['position'])) {
            $model->position = $map['position'];
        }

        return $model;
    }
}
