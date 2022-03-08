<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\ListApplicationAuthorizationServiceApplicationInformationResponseBody\applicationInformation;

use AlibabaCloud\Tea\Model;

class usagePlugins extends Model
{
    /**
     * @description iconUrl
     *
     * @var string
     */
    public $iconUrl;

    /**
     * @description pluginName
     *
     * @var string
     */
    public $pluginName;
    protected $_name = [
        'iconUrl'    => 'iconUrl',
        'pluginName' => 'pluginName',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->iconUrl) {
            $res['iconUrl'] = $this->iconUrl;
        }
        if (null !== $this->pluginName) {
            $res['pluginName'] = $this->pluginName;
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
        if (isset($map['iconUrl'])) {
            $model->iconUrl = $map['iconUrl'];
        }
        if (isset($map['pluginName'])) {
            $model->pluginName = $map['pluginName'];
        }

        return $model;
    }
}
