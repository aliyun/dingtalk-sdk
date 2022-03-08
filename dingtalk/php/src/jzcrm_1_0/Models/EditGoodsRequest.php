<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vjzcrm_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vjzcrm_1_0\Models\EditGoodsRequest\data;
use AlibabaCloud\Tea\Model;

class EditGoodsRequest extends Model
{
    /**
     * @description 编辑数据
     *
     * @var data
     */
    public $data;

    /**
     * @description 数据类型，固定填写154
     *
     * @var int
     */
    public $datatype;

    /**
     * @description 数据id，不填或者填0为新增数据
     *
     * @var int
     */
    public $msgid;

    /**
     * @description 时间戳
     *
     * @var int
     */
    public $stamp;
    protected $_name = [
        'data'     => 'data',
        'datatype' => 'datatype',
        'msgid'    => 'msgid',
        'stamp'    => 'stamp',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->data) {
            $res['data'] = null !== $this->data ? $this->data->toMap() : null;
        }
        if (null !== $this->datatype) {
            $res['datatype'] = $this->datatype;
        }
        if (null !== $this->msgid) {
            $res['msgid'] = $this->msgid;
        }
        if (null !== $this->stamp) {
            $res['stamp'] = $this->stamp;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return EditGoodsRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['data'])) {
            $model->data = data::fromMap($map['data']);
        }
        if (isset($map['datatype'])) {
            $model->datatype = $map['datatype'];
        }
        if (isset($map['msgid'])) {
            $model->msgid = $map['msgid'];
        }
        if (isset($map['stamp'])) {
            $model->stamp = $map['stamp'];
        }

        return $model;
    }
}
