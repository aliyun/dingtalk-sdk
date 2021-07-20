<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontent_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetFeedRequest extends Model
{
    /**
     * @description 入驻账号Id(请联系钉钉接口同学获取)
     *
     * @var string
     */
    public $mcnId;
    protected $_name = [
        'mcnId' => 'mcnId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->mcnId) {
            $res['mcnId'] = $this->mcnId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetFeedRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['mcnId'])) {
            $model->mcnId = $map['mcnId'];
        }

        return $model;
    }
}
