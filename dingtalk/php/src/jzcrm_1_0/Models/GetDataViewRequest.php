<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vjzcrm_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetDataViewRequest extends Model
{
    /**
     * @example 150
     *
     * @var string
     */
    public $datatype;

    /**
     * @example 1
     *
     * @var int
     */
    public $msgid;
    protected $_name = [
        'datatype' => 'datatype',
        'msgid'    => 'msgid',
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
        if (null !== $this->msgid) {
            $res['msgid'] = $this->msgid;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetDataViewRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['datatype'])) {
            $model->datatype = $map['datatype'];
        }
        if (isset($map['msgid'])) {
            $model->msgid = $map['msgid'];
        }

        return $model;
    }
}
