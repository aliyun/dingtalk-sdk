<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetOaOperatorLogListResponseBody;

use AlibabaCloud\Tea\Model;

class data extends Model
{
    /**
     * @description 操作分类（一级）
     *
     * @var string
     */
    public $category1Name;

    /**
     * @description 操作分类（二级）
     *
     * @var string
     */
    public $category2Name;

    /**
     * @description 操作详情
     *
     * @var string
     */
    public $content;

    /**
     * @description 操作员名字
     *
     * @var string
     */
    public $opName;

    /**
     * @description 操作时间
     *
     * @var int
     */
    public $opTime;

    /**
     * @description 操作员userId
     *
     * @var string
     */
    public $opUserId;
    protected $_name = [
        'category1Name' => 'category1Name',
        'category2Name' => 'category2Name',
        'content'       => 'content',
        'opName'        => 'opName',
        'opTime'        => 'opTime',
        'opUserId'      => 'opUserId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->category1Name) {
            $res['category1Name'] = $this->category1Name;
        }
        if (null !== $this->category2Name) {
            $res['category2Name'] = $this->category2Name;
        }
        if (null !== $this->content) {
            $res['content'] = $this->content;
        }
        if (null !== $this->opName) {
            $res['opName'] = $this->opName;
        }
        if (null !== $this->opTime) {
            $res['opTime'] = $this->opTime;
        }
        if (null !== $this->opUserId) {
            $res['opUserId'] = $this->opUserId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return data
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['category1Name'])) {
            $model->category1Name = $map['category1Name'];
        }
        if (isset($map['category2Name'])) {
            $model->category2Name = $map['category2Name'];
        }
        if (isset($map['content'])) {
            $model->content = $map['content'];
        }
        if (isset($map['opName'])) {
            $model->opName = $map['opName'];
        }
        if (isset($map['opTime'])) {
            $model->opTime = $map['opTime'];
        }
        if (isset($map['opUserId'])) {
            $model->opUserId = $map['opUserId'];
        }

        return $model;
    }
}
