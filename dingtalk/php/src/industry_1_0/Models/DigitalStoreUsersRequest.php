<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\Tea\Model;

class DigitalStoreUsersRequest extends Model
{
    /**
     * @description 门店通通讯录Cod
     *
     * @var string
     */
    public $code;

    /**
     * @description 节点Id
     *
     * @var int
     */
    public $nodeId;
    protected $_name = [
        'code'   => 'code',
        'nodeId' => 'nodeId',
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
        if (null !== $this->nodeId) {
            $res['nodeId'] = $this->nodeId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return DigitalStoreUsersRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['code'])) {
            $model->code = $map['code'];
        }
        if (isset($map['nodeId'])) {
            $model->nodeId = $map['nodeId'];
        }

        return $model;
    }
}
