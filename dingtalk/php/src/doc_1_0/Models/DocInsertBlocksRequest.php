<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models;

use AlibabaCloud\Tea\Model;

class DocInsertBlocksRequest extends Model
{
    /**
     * @example block_id
     *
     * @var string
     */
    public $blockId;

    /**
     * @example element
     *
     * @var mixed[]
     */
    public $element;

    /**
     * @example index
     *
     * @var int
     */
    public $index;

    /**
     * @example where
     *
     * @var string
     */
    public $where;

    /**
     * @example union_id
     *
     * @var string
     */
    public $operatorId;
    protected $_name = [
        'blockId'    => 'blockId',
        'element'    => 'element',
        'index'      => 'index',
        'where'      => 'where',
        'operatorId' => 'operatorId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->blockId) {
            $res['blockId'] = $this->blockId;
        }
        if (null !== $this->element) {
            $res['element'] = $this->element;
        }
        if (null !== $this->index) {
            $res['index'] = $this->index;
        }
        if (null !== $this->where) {
            $res['where'] = $this->where;
        }
        if (null !== $this->operatorId) {
            $res['operatorId'] = $this->operatorId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return DocInsertBlocksRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['blockId'])) {
            $model->blockId = $map['blockId'];
        }
        if (isset($map['element'])) {
            $model->element = $map['element'];
        }
        if (isset($map['index'])) {
            $model->index = $map['index'];
        }
        if (isset($map['where'])) {
            $model->where = $map['where'];
        }
        if (isset($map['operatorId'])) {
            $model->operatorId = $map['operatorId'];
        }

        return $model;
    }
}
