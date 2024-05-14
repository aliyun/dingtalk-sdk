<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models;

use AlibabaCloud\Tea\Model;

class SearchDepartmentRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 0
     *
     * @var int
     */
    public $offset;

    /**
     * @description This parameter is required.
     *
     * @example 财务部
     *
     * @var string
     */
    public $queryWord;

    /**
     * @description This parameter is required.
     *
     * @example 10
     *
     * @var int
     */
    public $size;
    protected $_name = [
        'offset'    => 'offset',
        'queryWord' => 'queryWord',
        'size'      => 'size',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->offset) {
            $res['offset'] = $this->offset;
        }
        if (null !== $this->queryWord) {
            $res['queryWord'] = $this->queryWord;
        }
        if (null !== $this->size) {
            $res['size'] = $this->size;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SearchDepartmentRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['offset'])) {
            $model->offset = $map['offset'];
        }
        if (isset($map['queryWord'])) {
            $model->queryWord = $map['queryWord'];
        }
        if (isset($map['size'])) {
            $model->size = $map['size'];
        }

        return $model;
    }
}
