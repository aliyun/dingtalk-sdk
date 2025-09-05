<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models;

use AlibabaCloud\Tea\Model;

class SearchFlowRequest extends Model
{
    /**
     * @example 20
     *
     * @var string
     */
    public $cursor;

    /**
     * @description This parameter is required.
     *
     * @example 1626861600000
     *
     * @var int
     */
    public $maxModifyTimeMills;

    /**
     * @description This parameter is required.
     *
     * @example 1626861600000
     *
     * @var int
     */
    public $minModifyTimeMills;

    /**
     * @example 20
     *
     * @var int
     */
    public $size;

    /**
     * @description This parameter is required.
     *
     * @example xxx
     *
     * @var string
     */
    public $opUserId;
    protected $_name = [
        'cursor' => 'cursor',
        'maxModifyTimeMills' => 'maxModifyTimeMills',
        'minModifyTimeMills' => 'minModifyTimeMills',
        'size' => 'size',
        'opUserId' => 'opUserId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->cursor) {
            $res['cursor'] = $this->cursor;
        }
        if (null !== $this->maxModifyTimeMills) {
            $res['maxModifyTimeMills'] = $this->maxModifyTimeMills;
        }
        if (null !== $this->minModifyTimeMills) {
            $res['minModifyTimeMills'] = $this->minModifyTimeMills;
        }
        if (null !== $this->size) {
            $res['size'] = $this->size;
        }
        if (null !== $this->opUserId) {
            $res['opUserId'] = $this->opUserId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SearchFlowRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['cursor'])) {
            $model->cursor = $map['cursor'];
        }
        if (isset($map['maxModifyTimeMills'])) {
            $model->maxModifyTimeMills = $map['maxModifyTimeMills'];
        }
        if (isset($map['minModifyTimeMills'])) {
            $model->minModifyTimeMills = $map['minModifyTimeMills'];
        }
        if (isset($map['size'])) {
            $model->size = $map['size'];
        }
        if (isset($map['opUserId'])) {
            $model->opUserId = $map['opUserId'];
        }

        return $model;
    }
}
