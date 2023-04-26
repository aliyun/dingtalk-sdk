<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\ListSpaceSectionsResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\SpaceModel;
use AlibabaCloud\Tea\Model;

class items extends Model
{
    /**
     * @example base
     *
     * @var string
     */
    public $displayType;

    /**
     * @example abc
     *
     * @var string
     */
    public $id;

    /**
     * @example 测试分组
     *
     * @var string
     */
    public $name;

    /**
     * @example 1
     *
     * @var int
     */
    public $spaceNum;

    /**
     * @var SpaceModel[]
     */
    public $spaces;
    protected $_name = [
        'displayType' => 'displayType',
        'id'          => 'id',
        'name'        => 'name',
        'spaceNum'    => 'spaceNum',
        'spaces'      => 'spaces',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->displayType) {
            $res['displayType'] = $this->displayType;
        }
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->spaceNum) {
            $res['spaceNum'] = $this->spaceNum;
        }
        if (null !== $this->spaces) {
            $res['spaces'] = [];
            if (null !== $this->spaces && \is_array($this->spaces)) {
                $n = 0;
                foreach ($this->spaces as $item) {
                    $res['spaces'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return items
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['displayType'])) {
            $model->displayType = $map['displayType'];
        }
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['spaceNum'])) {
            $model->spaceNum = $map['spaceNum'];
        }
        if (isset($map['spaces'])) {
            if (!empty($map['spaces'])) {
                $model->spaces = [];
                $n             = 0;
                foreach ($map['spaces'] as $item) {
                    $model->spaces[$n++] = null !== $item ? SpaceModel::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
