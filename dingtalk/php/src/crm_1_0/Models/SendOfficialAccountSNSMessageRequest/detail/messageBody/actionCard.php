<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\SendOfficialAccountSNSMessageRequest\detail\messageBody;

use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\SendOfficialAccountSNSMessageRequest\detail\messageBody\actionCard\buttonList;
use AlibabaCloud\Tea\Model;

class actionCard extends Model
{
    /**
     * @description 使用独立跳转ActionCard样式时的按钮列表；必须与buttonOrientation同时设置，且长度不超过1000字符。
     *
     * @var buttonList[]
     */
    public $buttonList;

    /**
     * @description 按钮排列方式： 0：竖直排列 1：横向排列 必须与buttonList同时设置。
     *
     * @var string
     */
    public $buttonOrientation;

    /**
     * @description 消息内容，支持markdown，语法参考标准markdown语法。1000个字符以内。
     *
     * @var string
     */
    public $markdown;

    /**
     * @description 使用整体跳转ActionCard样式时的标题。必须与singleUrl同时设置，最长20个字符。
     *
     * @var string
     */
    public $singleTitle;

    /**
     * @description 消息点击链接地址，当发送消息为小程序时支持小程序跳转链接，最长500个字符。
     *
     * @var string
     */
    public $singleUrl;

    /**
     * @description 透出到会话列表和通知的文案
     *
     * @var string
     */
    public $title;
    protected $_name = [
        'buttonList'        => 'buttonList',
        'buttonOrientation' => 'buttonOrientation',
        'markdown'          => 'markdown',
        'singleTitle'       => 'singleTitle',
        'singleUrl'         => 'singleUrl',
        'title'             => 'title',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->buttonList) {
            $res['buttonList'] = [];
            if (null !== $this->buttonList && \is_array($this->buttonList)) {
                $n = 0;
                foreach ($this->buttonList as $item) {
                    $res['buttonList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->buttonOrientation) {
            $res['buttonOrientation'] = $this->buttonOrientation;
        }
        if (null !== $this->markdown) {
            $res['markdown'] = $this->markdown;
        }
        if (null !== $this->singleTitle) {
            $res['singleTitle'] = $this->singleTitle;
        }
        if (null !== $this->singleUrl) {
            $res['singleUrl'] = $this->singleUrl;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return actionCard
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['buttonList'])) {
            if (!empty($map['buttonList'])) {
                $model->buttonList = [];
                $n                 = 0;
                foreach ($map['buttonList'] as $item) {
                    $model->buttonList[$n++] = null !== $item ? buttonList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['buttonOrientation'])) {
            $model->buttonOrientation = $map['buttonOrientation'];
        }
        if (isset($map['markdown'])) {
            $model->markdown = $map['markdown'];
        }
        if (isset($map['singleTitle'])) {
            $model->singleTitle = $map['singleTitle'];
        }
        if (isset($map['singleUrl'])) {
            $model->singleUrl = $map['singleUrl'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }

        return $model;
    }
}
