<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\GetProjectGroupResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @example 2022-06-13T07:36:50.318Z
     *
     * @var string
     */
    public $created;

    /**
     * @example 6215dce28972510xxxxx
     *
     * @var string
     */
    public $id;

    /**
     * @example 分组1
     *
     * @var string
     */
    public $name;

    /**
     * @example 2022-06-13T07:36:50.318Z
     *
     * @var string
     */
    public $updated;

    /**
     * @example organization
     *
     * @var string
     */
    public $visible;
    protected $_name = [
        'created' => 'created',
        'id' => 'id',
        'name' => 'name',
        'updated' => 'updated',
        'visible' => 'visible',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->created) {
            $res['created'] = $this->created;
        }
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->updated) {
            $res['updated'] = $this->updated;
        }
        if (null !== $this->visible) {
            $res['visible'] = $this->visible;
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
        if (isset($map['created'])) {
            $model->created = $map['created'];
        }
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['updated'])) {
            $model->updated = $map['updated'];
        }
        if (isset($map['visible'])) {
            $model->visible = $map['visible'];
        }

        return $model;
    }
}
