<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vpedia_1_0\Models\PediaWordsUpdateRequest;

use AlibabaCloud\Tea\Model;

class appLink extends Model
{
    /**
     * @description 应用名称
     *
     * @var string
     */
    public $appName;

    /**
     * @description icon地址
     *
     * @var string
     */
    public $iconLink;

    /**
     * @description 电脑端地址
     *
     * @var string
     */
    public $pcLink;

    /**
     * @description 手机端地址
     *
     * @var string
     */
    public $phoneLink;
    protected $_name = [
        'appName'   => 'appName',
        'iconLink'  => 'iconLink',
        'pcLink'    => 'pcLink',
        'phoneLink' => 'phoneLink',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->appName) {
            $res['appName'] = $this->appName;
        }
        if (null !== $this->iconLink) {
            $res['iconLink'] = $this->iconLink;
        }
        if (null !== $this->pcLink) {
            $res['pcLink'] = $this->pcLink;
        }
        if (null !== $this->phoneLink) {
            $res['phoneLink'] = $this->phoneLink;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return appLink
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['appName'])) {
            $model->appName = $map['appName'];
        }
        if (isset($map['iconLink'])) {
            $model->iconLink = $map['iconLink'];
        }
        if (isset($map['pcLink'])) {
            $model->pcLink = $map['pcLink'];
        }
        if (isset($map['phoneLink'])) {
            $model->phoneLink = $map['phoneLink'];
        }

        return $model;
    }
}
