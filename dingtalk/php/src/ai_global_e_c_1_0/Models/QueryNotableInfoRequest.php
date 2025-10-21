<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vai_global_e_c_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryNotableInfoRequest extends Model
{
    /**
     * @var string
     */
    public $sceneCode;
    protected $_name = [
        'sceneCode' => 'sceneCode',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->sceneCode) {
            $res['sceneCode'] = $this->sceneCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryNotableInfoRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['sceneCode'])) {
            $model->sceneCode = $map['sceneCode'];
        }

        return $model;
    }
}
