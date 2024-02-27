<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetMsgConfigResponseBody\data\groupAttributes;

use AlibabaCloud\Tea\Model;

class listDynamicAttr extends Model
{
    /**
     * @var string
     */
    public $attrCode;

    /**
     * @var string[]
     */
    public $listAttrOptionsCode;
    protected $_name = [
        'attrCode'            => 'attrCode',
        'listAttrOptionsCode' => 'listAttrOptionsCode',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->attrCode) {
            $res['attrCode'] = $this->attrCode;
        }
        if (null !== $this->listAttrOptionsCode) {
            $res['listAttrOptionsCode'] = $this->listAttrOptionsCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return listDynamicAttr
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['attrCode'])) {
            $model->attrCode = $map['attrCode'];
        }
        if (isset($map['listAttrOptionsCode'])) {
            if (!empty($map['listAttrOptionsCode'])) {
                $model->listAttrOptionsCode = $map['listAttrOptionsCode'];
            }
        }

        return $model;
    }
}
