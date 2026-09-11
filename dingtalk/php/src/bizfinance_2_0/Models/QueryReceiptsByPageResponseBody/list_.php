<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\QueryReceiptsByPageResponseBody;

use AlibabaCloud\Tea\Model;

class list_ extends Model
{
    /**
     * @var string
     */
    public $appId;

    /**
     * @var string
     */
    public $data;

    /**
     * @var string
     */
    public $modelId;

    /**
     * @var string
     */
    public $source;
    protected $_name = [
        'appId' => 'appId',
        'data' => 'data',
        'modelId' => 'modelId',
        'source' => 'source',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->appId) {
            $res['appId'] = $this->appId;
        }
        if (null !== $this->data) {
            $res['data'] = $this->data;
        }
        if (null !== $this->modelId) {
            $res['modelId'] = $this->modelId;
        }
        if (null !== $this->source) {
            $res['source'] = $this->source;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return list_
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['appId'])) {
            $model->appId = $map['appId'];
        }
        if (isset($map['data'])) {
            $model->data = $map['data'];
        }
        if (isset($map['modelId'])) {
            $model->modelId = $map['modelId'];
        }
        if (isset($map['source'])) {
            $model->source = $map['source'];
        }

        return $model;
    }
}
