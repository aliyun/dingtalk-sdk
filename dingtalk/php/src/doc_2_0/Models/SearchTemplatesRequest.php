<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\SearchTemplatesRequest\option;
use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\SearchTemplatesRequest\param;
use AlibabaCloud\Tea\Model;

class SearchTemplatesRequest extends Model
{
    /**
     * @var option
     */
    public $option;

    /**
     * @description This parameter is required.
     *
     * @var param
     */
    public $param;

    /**
     * @description This parameter is required.
     *
     * @example union_id
     *
     * @var string
     */
    public $operatorId;
    protected $_name = [
        'option' => 'option',
        'param' => 'param',
        'operatorId' => 'operatorId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->option) {
            $res['option'] = null !== $this->option ? $this->option->toMap() : null;
        }
        if (null !== $this->param) {
            $res['param'] = null !== $this->param ? $this->param->toMap() : null;
        }
        if (null !== $this->operatorId) {
            $res['operatorId'] = $this->operatorId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SearchTemplatesRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['option'])) {
            $model->option = option::fromMap($map['option']);
        }
        if (isset($map['param'])) {
            $model->param = param::fromMap($map['param']);
        }
        if (isset($map['operatorId'])) {
            $model->operatorId = $map['operatorId'];
        }

        return $model;
    }
}
