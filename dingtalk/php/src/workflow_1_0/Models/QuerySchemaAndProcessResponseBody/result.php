<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\QuerySchemaAndProcessResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var int
     */
    public $appType;

    /**
     * @var string
     */
    public $content;

    /**
     * @var string
     */
    public $handSignEnable;

    /**
     * @var string
     */
    public $iconUrl;

    /**
     * @var string
     */
    public $name;

    /**
     * @var string
     */
    public $processConfig;
    protected $_name = [
        'appType'        => 'appType',
        'content'        => 'content',
        'handSignEnable' => 'handSignEnable',
        'iconUrl'        => 'iconUrl',
        'name'           => 'name',
        'processConfig'  => 'processConfig',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->appType) {
            $res['appType'] = $this->appType;
        }
        if (null !== $this->content) {
            $res['content'] = $this->content;
        }
        if (null !== $this->handSignEnable) {
            $res['handSignEnable'] = $this->handSignEnable;
        }
        if (null !== $this->iconUrl) {
            $res['iconUrl'] = $this->iconUrl;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->processConfig) {
            $res['processConfig'] = $this->processConfig;
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
        if (isset($map['appType'])) {
            $model->appType = $map['appType'];
        }
        if (isset($map['content'])) {
            $model->content = $map['content'];
        }
        if (isset($map['handSignEnable'])) {
            $model->handSignEnable = $map['handSignEnable'];
        }
        if (isset($map['iconUrl'])) {
            $model->iconUrl = $map['iconUrl'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['processConfig'])) {
            $model->processConfig = $map['processConfig'];
        }

        return $model;
    }
}
