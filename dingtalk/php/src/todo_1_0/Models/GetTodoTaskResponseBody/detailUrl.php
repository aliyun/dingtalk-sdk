<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models\GetTodoTaskResponseBody;

use AlibabaCloud\Tea\Model;

class detailUrl extends Model
{
    /**
     * @description pc端详情页地址
     *
     * @var string
     */
    public $pcUrl;

    /**
     * @description app端详情页地址
     *
     * @var string
     */
    public $appUrl;
    protected $_name = [
        'pcUrl'  => 'pcUrl',
        'appUrl' => 'appUrl',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->pcUrl) {
            $res['pcUrl'] = $this->pcUrl;
        }
        if (null !== $this->appUrl) {
            $res['appUrl'] = $this->appUrl;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return detailUrl
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['pcUrl'])) {
            $model->pcUrl = $map['pcUrl'];
        }
        if (isset($map['appUrl'])) {
            $model->appUrl = $map['appUrl'];
        }

        return $model;
    }
}
