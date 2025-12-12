<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vagoal_1_0\Models;

use AlibabaCloud\Tea\Model;

class AgoalIndicatorBatchQueryRequest extends Model
{
    /**
     * @var string[]
     */
    public $codeList;
    protected $_name = [
        'codeList' => 'codeList',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->codeList) {
            $res['codeList'] = $this->codeList;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AgoalIndicatorBatchQueryRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['codeList'])) {
            if (!empty($map['codeList'])) {
                $model->codeList = $map['codeList'];
            }
        }

        return $model;
    }
}
