<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetProcessDesignResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetProcessDesignResponseBody\nodes\name;
use AlibabaCloud\Tea\Model;

class nodes extends Model
{
    /**
     * @var mixed[][]
     */
    public $childNodes;

    /**
     * @example 请选择审批人
     *
     * @var string
     */
    public $description;

    /**
     * @var name
     */
    public $name;

    /**
     * @var string[]
     */
    public $nextId;

    /**
     * @example node_xxx
     *
     * @var string
     */
    public $nodeId;

    /**
     * @example node_xxx
     *
     * @var string
     */
    public $prevId;

    /**
     * @var mixed[]
     */
    public $props;

    /**
     * @example approval
     *
     * @var string
     */
    public $type;
    protected $_name = [
        'childNodes' => 'childNodes',
        'description' => 'description',
        'name' => 'name',
        'nextId' => 'nextId',
        'nodeId' => 'nodeId',
        'prevId' => 'prevId',
        'props' => 'props',
        'type' => 'type',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->childNodes) {
            $res['childNodes'] = $this->childNodes;
        }
        if (null !== $this->description) {
            $res['description'] = $this->description;
        }
        if (null !== $this->name) {
            $res['name'] = null !== $this->name ? $this->name->toMap() : null;
        }
        if (null !== $this->nextId) {
            $res['nextId'] = $this->nextId;
        }
        if (null !== $this->nodeId) {
            $res['nodeId'] = $this->nodeId;
        }
        if (null !== $this->prevId) {
            $res['prevId'] = $this->prevId;
        }
        if (null !== $this->props) {
            $res['props'] = $this->props;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return nodes
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['childNodes'])) {
            if (!empty($map['childNodes'])) {
                $model->childNodes = $map['childNodes'];
            }
        }
        if (isset($map['description'])) {
            $model->description = $map['description'];
        }
        if (isset($map['name'])) {
            $model->name = name::fromMap($map['name']);
        }
        if (isset($map['nextId'])) {
            if (!empty($map['nextId'])) {
                $model->nextId = $map['nextId'];
            }
        }
        if (isset($map['nodeId'])) {
            $model->nodeId = $map['nodeId'];
        }
        if (isset($map['prevId'])) {
            $model->prevId = $map['prevId'];
        }
        if (isset($map['props'])) {
            $model->props = $map['props'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }

        return $model;
    }
}
