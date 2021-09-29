<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\ListApplicationInformationResponseBody\applicationInformation;

use AlibabaCloud\Tea\Model;

class usagePlugins extends Model
{
    /**
     * @description pluginName
     *
     * @var string
     */
    public $pluginName;

    /**
     * @description iconUrl
     *
     * @var string
     */
    public $iconUrl;
    protected $_name = [
        'pluginName' => 'pluginName',
        'iconUrl'    => 'iconUrl',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->pluginName) {
            $res['pluginName'] = $this->pluginName;
        }
        if (null !== $this->iconUrl) {
            $res['iconUrl'] = $this->iconUrl;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return usagePlugins
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['pluginName'])) {
            $model->pluginName = $map['pluginName'];
        }
        if (isset($map['iconUrl'])) {
            $model->iconUrl = $map['iconUrl'];
        }

        return $model;
    }
}
