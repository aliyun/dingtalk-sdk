<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\SearchProjectCustomFiledsV3ResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\SearchProjectCustomFiledsV3ResponseBody\result\advancedCustomfield;
use AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\SearchProjectCustomFiledsV3ResponseBody\result\choices;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var advancedCustomfield
     */
    public $advancedCustomfield;

    /**
     * @var string
     */
    public $boundToObjectId;

    /**
     * @var string
     */
    public $boundToObjectType;

    /**
     * @var choices[]
     */
    public $choices;

    /**
     * @example 2022-07-04T03:29:34.770Z
     *
     * @var string
     */
    public $created;

    /**
     * @var string
     */
    public $creatorId;

    /**
     * @var string
     */
    public $id;

    /**
     * @var string
     */
    public $name;

    /**
     * @var string
     */
    public $originalId;

    /**
     * @var string
     */
    public $type;
    protected $_name = [
        'advancedCustomfield' => 'advancedCustomfield',
        'boundToObjectId' => 'boundToObjectId',
        'boundToObjectType' => 'boundToObjectType',
        'choices' => 'choices',
        'created' => 'created',
        'creatorId' => 'creatorId',
        'id' => 'id',
        'name' => 'name',
        'originalId' => 'originalId',
        'type' => 'type',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->advancedCustomfield) {
            $res['advancedCustomfield'] = null !== $this->advancedCustomfield ? $this->advancedCustomfield->toMap() : null;
        }
        if (null !== $this->boundToObjectId) {
            $res['boundToObjectId'] = $this->boundToObjectId;
        }
        if (null !== $this->boundToObjectType) {
            $res['boundToObjectType'] = $this->boundToObjectType;
        }
        if (null !== $this->choices) {
            $res['choices'] = [];
            if (null !== $this->choices && \is_array($this->choices)) {
                $n = 0;
                foreach ($this->choices as $item) {
                    $res['choices'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->created) {
            $res['created'] = $this->created;
        }
        if (null !== $this->creatorId) {
            $res['creatorId'] = $this->creatorId;
        }
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->originalId) {
            $res['originalId'] = $this->originalId;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
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
        if (isset($map['advancedCustomfield'])) {
            $model->advancedCustomfield = advancedCustomfield::fromMap($map['advancedCustomfield']);
        }
        if (isset($map['boundToObjectId'])) {
            $model->boundToObjectId = $map['boundToObjectId'];
        }
        if (isset($map['boundToObjectType'])) {
            $model->boundToObjectType = $map['boundToObjectType'];
        }
        if (isset($map['choices'])) {
            if (!empty($map['choices'])) {
                $model->choices = [];
                $n = 0;
                foreach ($map['choices'] as $item) {
                    $model->choices[$n++] = null !== $item ? choices::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['created'])) {
            $model->created = $map['created'];
        }
        if (isset($map['creatorId'])) {
            $model->creatorId = $map['creatorId'];
        }
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['originalId'])) {
            $model->originalId = $map['originalId'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }

        return $model;
    }
}
