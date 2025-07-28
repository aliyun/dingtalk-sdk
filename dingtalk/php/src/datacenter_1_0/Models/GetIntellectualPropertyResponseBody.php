<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetIntellectualPropertyResponseBody extends Model
{
    /**
     * @example [     {       "Status": "有效",       "Type": "专利",       "Pledgor": "齐风莲",       "Number": "91611024MA70X17M7E",       "Period": "2015年06月11日至2015年06月11日",       "PublicDate": "2015-06-18 00:00:00",       "Pawnee": "齐风莲",       "entName": "东兰县鸿发摩托车安全技术检验有限公司"     }   ]
     *
     * @var string
     */
    public $data;

    /**
     * @var int
     */
    public $total;
    protected $_name = [
        'data' => 'data',
        'total' => 'total',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->data) {
            $res['data'] = $this->data;
        }
        if (null !== $this->total) {
            $res['total'] = $this->total;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetIntellectualPropertyResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['data'])) {
            $model->data = $map['data'];
        }
        if (isset($map['total'])) {
            $model->total = $map['total'];
        }

        return $model;
    }
}
