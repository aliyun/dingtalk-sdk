<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\QuerySmartDeviceAiSceneByIdResponseBody\agent;

use AlibabaCloud\Tea\Model;

class syncIsvSystemConfigs extends Model
{
    /**
     * @var string
     */
    public $description;

    /**
     * @var string
     */
    public $isvSystemKey;

    /**
     * @var string
     */
    public $state;

    /**
     * @var string
     */
    public $title;
    protected $_name = [
        'description' => 'description',
        'isvSystemKey' => 'isvSystemKey',
        'state' => 'state',
        'title' => 'title',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->description) {
            $res['description'] = $this->description;
        }
        if (null !== $this->isvSystemKey) {
            $res['isvSystemKey'] = $this->isvSystemKey;
        }
        if (null !== $this->state) {
            $res['state'] = $this->state;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return syncIsvSystemConfigs
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['description'])) {
            $model->description = $map['description'];
        }
        if (isset($map['isvSystemKey'])) {
            $model->isvSystemKey = $map['isvSystemKey'];
        }
        if (isset($map['state'])) {
            $model->state = $map['state'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }

        return $model;
    }
}
