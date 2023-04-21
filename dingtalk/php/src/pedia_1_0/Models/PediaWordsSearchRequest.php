<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vpedia_1_0\Models;

use AlibabaCloud\Tea\Model;

class PediaWordsSearchRequest extends Model
{
    /**
     * @description 当前查询的页数，当超过总数后返回数据为空
     *
     *
     * @var int
     */
    public $pageNumber;

    /**
     * @description 当前每页需要展示的数量，最大20
     *
     *
     * @var int
     */
    public $pageSize;

    /**
     * @description 当前搜索列表的状态0代表审核通过，1代表创建待审核，2代表更新待审核列表
     * 默认是0，代表获取所有审核完成的词条
     *
     * @var string
     */
    public $status;

    /**
     * @description 通过开放平台获取的员工编号userId
     *
     * @var string
     */
    public $userId;

    /**
     * @description 搜索关键词
     *
     *
     * @var string
     */
    public $wordName;
    protected $_name = [
        'pageNumber' => 'pageNumber',
        'pageSize'   => 'pageSize',
        'status'     => 'status',
        'userId'     => 'userId',
        'wordName'   => 'wordName',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->pageNumber) {
            $res['pageNumber'] = $this->pageNumber;
        }
        if (null !== $this->pageSize) {
            $res['pageSize'] = $this->pageSize;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }
        if (null !== $this->wordName) {
            $res['wordName'] = $this->wordName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return PediaWordsSearchRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['pageNumber'])) {
            $model->pageNumber = $map['pageNumber'];
        }
        if (isset($map['pageSize'])) {
            $model->pageSize = $map['pageSize'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }
        if (isset($map['wordName'])) {
            $model->wordName = $map['wordName'];
        }

        return $model;
    }
}
