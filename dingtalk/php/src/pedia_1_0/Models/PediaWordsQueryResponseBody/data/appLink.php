<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vpedia_1_0\Models\PediaWordsQueryResponseBody\data;

use AlibabaCloud\Tea\Model;

class appLink extends Model
{
    /**
     * @example 相关应用
     *
     * @var string
     */
    public $appName;

    /**
     * @example htttps://1234567
     *
     * @var string
     */
    public $iconLink;

    /**
     * @example http://123344.com
     *
     * @var string
     */
    public $pcLink;

    /**
     * @example https://12334.com
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
