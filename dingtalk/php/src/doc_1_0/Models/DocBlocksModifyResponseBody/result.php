<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\DocBlocksModifyResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var mixed[]
     */
    public $result;
    protected $_name = [
        'result' => 'result',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->result) {
            $res['result'] = $this->result;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['result'])) {
            if (!empty($map['result'])) {
                $model->result = $map['result'];
            }
        }

        return $model;
    }
}
