<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\CreateCustomerRequest;

use AlibabaCloud\Tea\Model;

class contacts extends Model
{
    /**
     * @description 联系人表单数据
     *
     * @var mixed[]
     */
    public $data;

    /**
     * @description 联系人扩展数据
     *
     * @var mixed[]
     */
    public $extendData;
    protected $_name = [
        'data'       => 'data',
        'extendData' => 'extendData',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->data) {
            $res['data'] = $this->data;
        }
        if (null !== $this->extendData) {
            $res['extendData'] = $this->extendData;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return contacts
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['data'])) {
            $model->data = $map['data'];
        }
        if (isset($map['extendData'])) {
            $model->extendData = $map['extendData'];
        }

        return $model;
    }
}
