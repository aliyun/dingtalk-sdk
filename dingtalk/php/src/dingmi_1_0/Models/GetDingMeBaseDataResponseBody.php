<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdingmi_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetDingMeBaseDataResponseBody extends Model
{
    /**
     * @description 是否缓存
     *
     * @var bool
     */
    public $fromCache;

    /**
     * @description 结果集
     *
     * @var string[][]
     */
    public $rawset;

    /**
     * @description 运行时间
     *
     * @var int
     */
    public $runtime;

    /**
     * @description 字段解释
     *
     * @var mixed[]
     */
    public $tips;
    protected $_name = [
        'fromCache' => 'fromCache',
        'rawset'    => 'rawset',
        'runtime'   => 'runtime',
        'tips'      => 'tips',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->fromCache) {
            $res['fromCache'] = $this->fromCache;
        }
        if (null !== $this->rawset) {
            $res['rawset'] = $this->rawset;
        }
        if (null !== $this->runtime) {
            $res['runtime'] = $this->runtime;
        }
        if (null !== $this->tips) {
            $res['tips'] = $this->tips;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetDingMeBaseDataResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['fromCache'])) {
            $model->fromCache = $map['fromCache'];
        }
        if (isset($map['rawset'])) {
            if (!empty($map['rawset'])) {
                $model->rawset = $map['rawset'];
            }
        }
        if (isset($map['runtime'])) {
            $model->runtime = $map['runtime'];
        }
        if (isset($map['tips'])) {
            $model->tips = $map['tips'];
        }

        return $model;
    }
}
