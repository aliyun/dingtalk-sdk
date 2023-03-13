<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models;

use AlibabaCloud\Tea\Model;

class QueryItemByUrlRequest extends Model
{
    /**
     * @description 操作用户unionId。
     *
     * @var string
     */
    public $operatorId;

    /**
     * @description 链接url。
     *
     * @var string
     */
    public $url;

    /**
     * @description 是否查询统计信息
     *
     * @var bool
     */
    public $withStatisticalInfo;
    protected $_name = [
        'operatorId'          => 'operatorId',
        'url'                 => 'url',
        'withStatisticalInfo' => 'withStatisticalInfo',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->operatorId) {
            $res['operatorId'] = $this->operatorId;
        }
        if (null !== $this->url) {
            $res['url'] = $this->url;
        }
        if (null !== $this->withStatisticalInfo) {
            $res['withStatisticalInfo'] = $this->withStatisticalInfo;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryItemByUrlRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['operatorId'])) {
            $model->operatorId = $map['operatorId'];
        }
        if (isset($map['url'])) {
            $model->url = $map['url'];
        }
        if (isset($map['withStatisticalInfo'])) {
            $model->withStatisticalInfo = $map['withStatisticalInfo'];
        }

        return $model;
    }
}
