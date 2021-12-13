<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vh3yun_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetAppsRequest extends Model
{
    /**
     * @description 查询类型。All=全部，Solution=以解决方案编码为条件来查询应用，AppCode=以应用编码为条件来查询
     *
     * @var string
     */
    public $queryType;

    /**
     * @description 待查询的编码数组。queryType参数为All时，此值可为空
     *
     * @var string[]
     */
    public $values;
    protected $_name = [
        'queryType' => 'queryType',
        'values'    => 'values',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->queryType) {
            $res['queryType'] = $this->queryType;
        }
        if (null !== $this->values) {
            $res['values'] = $this->values;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetAppsRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['queryType'])) {
            $model->queryType = $map['queryType'];
        }
        if (isset($map['values'])) {
            if (!empty($map['values'])) {
                $model->values = $map['values'];
            }
        }

        return $model;
    }
}
