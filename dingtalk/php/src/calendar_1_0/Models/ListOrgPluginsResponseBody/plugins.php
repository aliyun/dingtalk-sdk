<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\ListOrgPluginsResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\ListOrgPluginsResponseBody\plugins\subscribers;
use AlibabaCloud\Tea\Model;

class plugins extends Model
{
    /**
     * @var string
     */
    public $logo;

    /**
     * @var string
     */
    public $name;

    /**
     * @var string
     */
    public $pluginClassification;

    /**
     * @var string
     */
    public $pluginId;

    /**
     * @var subscribers
     */
    public $subscribers;
    protected $_name = [
        'logo' => 'logo',
        'name' => 'name',
        'pluginClassification' => 'pluginClassification',
        'pluginId' => 'pluginId',
        'subscribers' => 'subscribers',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->logo) {
            $res['logo'] = $this->logo;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->pluginClassification) {
            $res['pluginClassification'] = $this->pluginClassification;
        }
        if (null !== $this->pluginId) {
            $res['pluginId'] = $this->pluginId;
        }
        if (null !== $this->subscribers) {
            $res['subscribers'] = null !== $this->subscribers ? $this->subscribers->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return plugins
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['logo'])) {
            $model->logo = $map['logo'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['pluginClassification'])) {
            $model->pluginClassification = $map['pluginClassification'];
        }
        if (isset($map['pluginId'])) {
            $model->pluginId = $map['pluginId'];
        }
        if (isset($map['subscribers'])) {
            $model->subscribers = subscribers::fromMap($map['subscribers']);
        }

        return $model;
    }
}
