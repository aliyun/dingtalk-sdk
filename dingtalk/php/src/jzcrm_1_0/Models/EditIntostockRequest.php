<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vjzcrm_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vjzcrm_1_0\Models\EditIntostockRequest\data;
use AlibabaCloud\Tea\Model;

class EditIntostockRequest extends Model
{
    /**
     * @description 数据类型，固定填写189
     *
     * @var int
     */
    public $datatype;

    /**
     * @description 时间戳
     *
     * @var int
     */
    public $stamp;

    /**
     * @description 数据id，不填或者填0为新增数据
     *
     * @var int
     */
    public $msgid;

    /**
     * @description 编辑数据
     *
     * @var data
     */
    public $data;
    protected $_name = [
        'datatype' => 'datatype',
        'stamp'    => 'stamp',
        'msgid'    => 'msgid',
        'data'     => 'data',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->datatype) {
            $res['datatype'] = $this->datatype;
        }
        if (null !== $this->stamp) {
            $res['stamp'] = $this->stamp;
        }
        if (null !== $this->msgid) {
            $res['msgid'] = $this->msgid;
        }
        if (null !== $this->data) {
            $res['data'] = null !== $this->data ? $this->data->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return EditIntostockRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['datatype'])) {
            $model->datatype = $map['datatype'];
        }
        if (isset($map['stamp'])) {
            $model->stamp = $map['stamp'];
        }
        if (isset($map['msgid'])) {
            $model->msgid = $map['msgid'];
        }
        if (isset($map['data'])) {
            $model->data = data::fromMap($map['data']);
        }

        return $model;
    }
}
