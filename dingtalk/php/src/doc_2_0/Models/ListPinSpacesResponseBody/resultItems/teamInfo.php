<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\ListPinSpacesResponseBody\resultItems;

use AlibabaCloud\Tea\Model;

class teamInfo extends Model
{
    /**
     * @example team_id
     *
     * @var string
     */
    public $id;

    /**
     * @example team_name
     *
     * @var string
     */
    public $name;
    protected $_name = [
        'id'   => 'id',
        'name' => 'name',
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
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return teamInfo
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }

        return $model;
    }
}
