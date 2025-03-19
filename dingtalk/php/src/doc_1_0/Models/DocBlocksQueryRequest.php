<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models;

use AlibabaCloud\Tea\Model;

class DocBlocksQueryRequest extends Model
{
    /**
     * @example block_type
     *
     * @var string
     */
    public $blockType;

    /**
     * @example end_index
     *
     * @var int
     */
    public $endIndex;

    /**
     * @description This parameter is required.
     *
     * @example union_id
     *
     * @var string
     */
    public $operatorId;

    /**
     * @example start_index
     *
     * @var int
     */
    public $startIndex;
    protected $_name = [
        'blockType' => 'blockType',
        'endIndex' => 'endIndex',
        'operatorId' => 'operatorId',
        'startIndex' => 'startIndex',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->blockType) {
            $res['blockType'] = $this->blockType;
        }
        if (null !== $this->endIndex) {
            $res['endIndex'] = $this->endIndex;
        }
        if (null !== $this->operatorId) {
            $res['operatorId'] = $this->operatorId;
        }
        if (null !== $this->startIndex) {
            $res['startIndex'] = $this->startIndex;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return DocBlocksQueryRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['blockType'])) {
            $model->blockType = $map['blockType'];
        }
        if (isset($map['endIndex'])) {
            $model->endIndex = $map['endIndex'];
        }
        if (isset($map['operatorId'])) {
            $model->operatorId = $map['operatorId'];
        }
        if (isset($map['startIndex'])) {
            $model->startIndex = $map['startIndex'];
        }

        return $model;
    }
}
