<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vapaas_1_0\Models\QueryTemplateCategorysResponseBody;

use AlibabaCloud\Tea\Model;

class categoryList extends Model
{
    /**
     * @description 分类编码
     *
     * @var string
     */
    public $code;

    /**
     * @description 分类名称
     *
     * @var string
     */
    public $name;
    protected $_name = [
        'code' => 'code',
        'name' => 'name',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->code) {
            $res['code'] = $this->code;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return categoryList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['code'])) {
            $model->code = $map['code'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }

        return $model;
    }
}
