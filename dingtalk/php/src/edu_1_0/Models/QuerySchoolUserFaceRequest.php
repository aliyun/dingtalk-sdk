<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class QuerySchoolUserFaceRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 从0开始
     *
     * @var int
     */
    public $pageNumber;

    /**
     * @description This parameter is required.
     *
     * @example 大于0小于200
     *
     * @var int
     */
    public $pageSize;

    /**
     * @description This parameter is required.
     *
     * @example sn123
     *
     * @var string
     */
    public $sn;

    /**
     * @description This parameter is required.
     *
     * @example 1全量模式，2增量模式
     *
     * @var int
     */
    public $type;
    protected $_name = [
        'pageNumber' => 'pageNumber',
        'pageSize'   => 'pageSize',
        'sn'         => 'sn',
        'type'       => 'type',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->pageNumber) {
            $res['pageNumber'] = $this->pageNumber;
        }
        if (null !== $this->pageSize) {
            $res['pageSize'] = $this->pageSize;
        }
        if (null !== $this->sn) {
            $res['sn'] = $this->sn;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QuerySchoolUserFaceRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['pageNumber'])) {
            $model->pageNumber = $map['pageNumber'];
        }
        if (isset($map['pageSize'])) {
            $model->pageSize = $map['pageSize'];
        }
        if (isset($map['sn'])) {
            $model->sn = $map['sn'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }

        return $model;
    }
}
