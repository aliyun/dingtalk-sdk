<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vsalary_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vsalary_1_0\Models\SaveSalaryArchivesRequest\contents;
use AlibabaCloud\Tea\Model;

class SaveSalaryArchivesRequest extends Model
{
    /**
     * @example 转正
     *
     * @var string
     */
    public $adjustMemo;

    /**
     * @var contents[]
     */
    public $contents;

    /**
     * @description This parameter is required.
     *
     * @example 2025-06-01
     *
     * @var string
     */
    public $effectiveDate;

    /**
     * @description This parameter is required.
     *
     * @example user001
     *
     * @var string
     */
    public $opUserId;

    /**
     * @description This parameter is required.
     *
     * @example user001
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'adjustMemo' => 'adjustMemo',
        'contents' => 'contents',
        'effectiveDate' => 'effectiveDate',
        'opUserId' => 'opUserId',
        'userId' => 'userId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->adjustMemo) {
            $res['adjustMemo'] = $this->adjustMemo;
        }
        if (null !== $this->contents) {
            $res['contents'] = [];
            if (null !== $this->contents && \is_array($this->contents)) {
                $n = 0;
                foreach ($this->contents as $item) {
                    $res['contents'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->effectiveDate) {
            $res['effectiveDate'] = $this->effectiveDate;
        }
        if (null !== $this->opUserId) {
            $res['opUserId'] = $this->opUserId;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SaveSalaryArchivesRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['adjustMemo'])) {
            $model->adjustMemo = $map['adjustMemo'];
        }
        if (isset($map['contents'])) {
            if (!empty($map['contents'])) {
                $model->contents = [];
                $n = 0;
                foreach ($map['contents'] as $item) {
                    $model->contents[$n++] = null !== $item ? contents::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['effectiveDate'])) {
            $model->effectiveDate = $map['effectiveDate'];
        }
        if (isset($map['opUserId'])) {
            $model->opUserId = $map['opUserId'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
