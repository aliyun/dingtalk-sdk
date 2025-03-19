<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryAdvancedContractVersionRequest extends Model
{
    /**
     * @example dingff048f704a8b6d8e4ac5d6980864d335
     *
     * @var string
     */
    public $corpId;

    /**
     * @var string[]
     */
    public $extension;
    protected $_name = [
        'corpId' => 'corpId',
        'extension' => 'extension',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->extension) {
            $res['extension'] = $this->extension;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryAdvancedContractVersionRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['extension'])) {
            $model->extension = $map['extension'];
        }

        return $model;
    }
}
