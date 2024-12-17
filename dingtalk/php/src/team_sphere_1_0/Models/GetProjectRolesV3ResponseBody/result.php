<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\GetProjectRolesV3ResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var bool
     */
    public $display;

    /**
     * @var string
     */
    public $id;

    /**
     * @var bool
     */
    public $isDefaultRole;

    /**
     * @var int
     */
    public $level;

    /**
     * @var string
     */
    public $name;

    /**
     * @var string
     */
    public $originalId;
    protected $_name = [
        'display'       => 'display',
        'id'            => 'id',
        'isDefaultRole' => 'isDefaultRole',
        'level'         => 'level',
        'name'          => 'name',
        'originalId'    => 'originalId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->display) {
            $res['display'] = $this->display;
        }
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
        if (null !== $this->isDefaultRole) {
            $res['isDefaultRole'] = $this->isDefaultRole;
        }
        if (null !== $this->level) {
            $res['level'] = $this->level;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->originalId) {
            $res['originalId'] = $this->originalId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['display'])) {
            $model->display = $map['display'];
        }
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['isDefaultRole'])) {
            $model->isDefaultRole = $map['isDefaultRole'];
        }
        if (isset($map['level'])) {
            $model->level = $map['level'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['originalId'])) {
            $model->originalId = $map['originalId'];
        }

        return $model;
    }
}
